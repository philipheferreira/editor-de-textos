using System; 

namespace EditordeTexto { 
    class Program {  
        static void Main(string[] args) {
            Menu();
        }

        static void Menu() {

            int menuEditordeTexto;

            Console.Clear();
            Console.WriteLine("Digite qual tarefa voce gostaria de realizar a baixo");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - criar novo arquivo");
            Console.WriteLine("0 - Sair");

            menuEditordeTexto = Convert.ToInt32(Console.ReadLine());

            switch (menuEditordeTexto) {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }
        }

        static void Abrir() { 
        
        }

        static void Editar() { 
        
        }
    }
}