using Ascon.Plm.Loodsman.PluginSDK;
using Loodsman;
using System;
using System.Data;
using System.Windows.Forms;

namespace SampleNetPlugin
{
    [LoodsmanPlugin]
    internal class DemoPluginLoodsman : ILoodsmanNetPlugin
    {
        public string DBname;
        public string checkout;
        public FormPlugin newForm = new FormPlugin();
        public DemoPluginLoodsman()
        {
            _isAdmin = false;
        }

        private static bool _isAdmin;

        public void BindMenu(IMenuDefinition menu)
        {
            menu.AddMenuItem("Тест плагина#Запуск", Run, null);
        }

        private bool CheckCommand1(INetPluginCall arg)
        {
            if (arg != null)
            {
                if (arg.PluginCall.IdVersion != 0)
                    return true;
            }
            return false;
        }

        private void Run(INetPluginCall netPluginCall)
        {
            newForm.ShowDialog();
            var _netPluginCall = netPluginCall;
            var _pluginCall = netPluginCall.PluginCall;
            DBname = _netPluginCall.RunMethod("CurrentBase").ToString();;
            checkout = _netPluginCall.RunMethod("CheckOut", new object[] { _pluginCall.stType, _pluginCall.stProduct, _pluginCall.stVersion, 1 }).ToString(); // Создание чекаута, взятие ТП в работу
            _netPluginCall.RunMethod("ConnectToCheckOut", new object[] { checkout, DBname });   // Подключение к чекауту
            try
            {
                var newObjId = _netPluginCall.RunMethod("NewObject", new object[] { "Папка", "Общая папка", newForm.TBoxNameProject.Text, 1 });   // создаем новый объект
                _netPluginCall.RunMethod("AddToCheckOut", new object[] { newObjId, 0 });  // добавляем его в чекаут
                for (int i = 0; i < newForm.countDetail; i++)
                {
                    if (newForm.FileExtension[i] == ".a3d")
                    {
                        var AssemblyObj = _netPluginCall.RunMethod("NewObject", new object[] { "Сборочная единица", "Согласование", newForm.NameObj[i], 0 });   // создаем новый объект
                        
                        _netPluginCall.RunMethod("UpAttrValueById", new object[] { AssemblyObj, "Разработал", newForm.Staff[i], "", false }); // меняем разработчика объекта
                        
                        _netPluginCall.RunMethod("UpAttrValueById", new object[] { AssemblyObj, "Подразделение", newForm.Division[i], "", false }); // меняем подразделение у объекта
                        
                        _netPluginCall.RunMethod("AddToCheckOut", new object[] { AssemblyObj, 0 });  // добавляем его в чекаут
                        
                        _netPluginCall.RunMethod("NewLink", new object[] { newObjId, "", "", "", AssemblyObj, "", "", "", 0, 0, "", "Состоит из ..." }); // добавление связи между "Папка" и "Сборочная единица"
                        
                        var obj3dAssembly = _netPluginCall.RunMethod("NewObject", new object[] { "3D-модель сборки", "Согласование", newForm.NameObj[i], 0 });   // создаем новый объект
                        
                        _netPluginCall.RunMethod("UpAttrValueById", new object[] { obj3dAssembly, "Разработал", newForm.Staff[i], "", false }); // меняем разработчика объекта

                        _netPluginCall.RunMethod("UpAttrValueById", new object[] { obj3dAssembly, "Подразделение", newForm.Division[i], "", false }); // меняем подразделение
                        
                        _netPluginCall.RunMethod("AddToCheckOut", new object[] { obj3dAssembly, 0 });  // добавляем его в чекаут
                        
                        _netPluginCall.RunMethod("NewLink", new object[] { AssemblyObj, "", "", "", obj3dAssembly, "", "", "", 0, 0, "", "Документы" }); // добавление связи между "Сборочная единица" и "3D-модель сборки"
                        
                        _netPluginCall.RunMethod("UpFileById", new object[] { obj3dAssembly, newForm.Detail[i], newForm.FileTempPath[i], System.IO.File.ReadAllBytes(newForm.FilePath[i]), System.IO.File.GetCreationTime(newForm.FilePath[i]), false }); // добавление файла сборки к объекту
                    }
                    if (newForm.FileExtension[i] == ".m3d")
                    {
                        var DetailObj = _netPluginCall.RunMethod("NewObject", new object[] { "Деталь", "Согласование", newForm.NameObj[i], 0 });   // создаем новый объект
                        
                        _netPluginCall.RunMethod("UpAttrValueById", new object[] { DetailObj, "Разработал", newForm.Staff[i], "", false }); // меняем разработчика объекта

                        _netPluginCall.RunMethod("UpAttrValueById", new object[] { DetailObj, "Подразделение", newForm.Division[i], "", false }); // меняем подразделение у объекта

                        _netPluginCall.RunMethod("AddToCheckOut", new object[] { DetailObj, 0 });  // добавляем его в чекаут
                        
                        _netPluginCall.RunMethod("NewLink", new object[] { newObjId, "", "", "", DetailObj, "", "", "", 0, 0, "", "Состоит из ..." }); // добавление связи между "Папка" и "Деталь"

                        var obj3dDetail = _netPluginCall.RunMethod("NewObject", new object[] { "3D-модель детали", "Согласование", newForm.NameObj[i], 0 });   // создаем новый объект

                        _netPluginCall.RunMethod("UpAttrValueById", new object[] { obj3dDetail, "Разработал", newForm.Staff[i], "", false }); // меняем разработчика объекта

                        _netPluginCall.RunMethod("UpAttrValueById", new object[] { obj3dDetail, "Подразделение", newForm.Division[i], "", false }); // меняем подразделение у объекта

                        _netPluginCall.RunMethod("AddToCheckOut", new object[] { obj3dDetail, 0 });  // добавляем его в чекаут

                        _netPluginCall.RunMethod("NewLink", new object[] { DetailObj, "", "", "", obj3dDetail, "", "", "", 0, 0, "", "Документы" }); // добавление связи между "Деталь" и "3D-модель детали"

                        _netPluginCall.RunMethod("UpFileById", new object[] { obj3dDetail, newForm.Detail[i], newForm.FileTempPath[i], System.IO.File.ReadAllBytes(newForm.FilePath[i]), System.IO.File.GetCreationTime(newForm.FilePath[i]), false }); // добавление файла детали к объекту
                    }
                }
                _netPluginCall.RunMethod("CheckIn", new object[] { checkout, DBname }); // Возвращение объекта из работы
                _netPluginCall.RunMethod("DisconnectCheckOut", new object[] { checkout, DBname });
            }
            catch (Exception ex)
            {
                _netPluginCall.RunMethod("CancelCheckOut", new object[] { checkout, DBname }); // Отказ от изменения объекта
                throw new Exception();
            }
            var app = (ILoodsmanApplication)_pluginCall;
            var content = app.ActiveWindow.Content;
            var frame = (IFrameContainer)content;
            frame.StartRefresh(false);
        }

        public void OnCloseDb()
        {
            _isAdmin = false;
        }

        public void OnConnectToDb(INetPluginCall call)
        {
            if (call != null)
                _isAdmin = (int)call.RunMethod("IsAdmin") == 1;
        }

        public void PluginLoad()
        {
            //System.Windows.Forms.MessageBox.Show("PluginLoad");
            _isAdmin = false;
        }

        public void PluginUnload()
        {
            //System.Windows.Forms.MessageBox.Show("PluginUnload");
        }
    }
}
