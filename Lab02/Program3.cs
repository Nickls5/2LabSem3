using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Lab02
{

    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите ключ доступа pro/exp:");
            string key;
            key = Console.ReadLine();
            DocumentWorker documentwork;
            if (key == "pro")
            {
                documentwork = new ProDocumentWorker();
            } 
            else if (key == "exp")
            {
                documentwork = new ExpertDocumentWorker();
            }
            else
            {
                documentwork = new DocumentWorker();
            }

            documentwork.OpenDocument();
            documentwork.EditDocument();
            documentwork.SaveDocument();
        }
    }
    public class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Pro");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Pro");
        }
    }

    public class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
        }
    }

    public class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument() 
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }






}

