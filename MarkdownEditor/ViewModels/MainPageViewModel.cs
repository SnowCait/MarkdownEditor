using Core.Markdown;
using Prism.Windows.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkdownEditor.ViewModels
{
    class MainPageViewModel : ViewModelBase
    {
        private string markdownText = string.Empty;

        public string MarkdownText
        {
            get { return markdownText; }
            set { SetProperty(ref markdownText, value); }
        }
        
        public async Task<string> ConvertAsync()
        {
            return await Markdown.MarkdownToHTML(MarkdownText);
        }
    }
}
