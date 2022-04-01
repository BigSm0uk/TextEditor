using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextEditor_Core;

namespace TextEditor
{
    public class Presentor
    {
        private readonly IMainForm _view;
        private readonly IMessageService _messageService;
        private readonly IFileManager _manager;

        private string _currentFilePath;

        public Presentor(IMainForm view , IFileManager fileManager , IMessageService service)
        {
            _view = view;
            _manager = fileManager;
            _messageService = service;

            _view.SetSymbolCount(0);

            _view.ContentChanged += _view_ContentChanged;
            _view.FileOpenClick += _view_FileOpenClick;
            _view.FileSaveClick += _view_FileSaveClick;
        }

        private void _view_FileSaveClick(object sender, EventArgs e)
        {
            try
            {
                string content = _view.Content;
                _manager.SaveContent(content, _currentFilePath);
                _messageService.ShowMessage("Файл успешно сохранен");
            }
            catch(Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }

        private void _view_FileOpenClick(object sender, EventArgs e)
        {
            try
            {
                string filePath = _view.Path;
                bool isExist = _manager.IsExist(filePath);
                if (!isExist)
                {
                    _messageService.ShowExclamation("Выбранный путь не существует!");
                    return;
                }
                _currentFilePath = filePath;
                string content = _manager.GetContent(_currentFilePath);
                int count = _manager.GetSymbolCount(content);

                
                _view.Content = content;
                _view.SetSymbolCount(count);
            }
            catch(Exception ex)
            { _messageService.ShowError(ex.Message); }
        }

        private void _view_ContentChanged(object sender, EventArgs e)
        {
            string content = _view.Content;
            int count = _manager.GetSymbolCount(content);
            _view.SetSymbolCount(count);
        }
    }

}
