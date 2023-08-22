using System;
namespace Carro{ 
namespace EstudoC_Sharp
{
    public class Program{

        public static void Main(String[] args){

            Carro meuCarro = new Carro();

            meuCarro.buzinar();
            Console.WriteLine(meuCarro.Marca + " " + meuCarro.nomeModelo);
 
        } 
    }
}
}

// "Sealed" class makes impossible for other classes to inherit from a specific class.