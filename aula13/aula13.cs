using System;

class Aula13 {

    static void Main() {

        while(true){

        
            try{
                Console.Write("Digite a nota do aluno: ");
                int nota = int.Parse(Console.ReadLine());
                string resultado = "Reprovado";
        
        

                if(nota >= 6) {
                    resultado = "Aprovado";
                }

                else if (nota < 6 && nota >= 4) {
                    resultado = "Recuperação";
                }

                else {
                    resultado = "Reprovado";
                }

                Console.WriteLine("Resultado: {0}", resultado);
                    break;
                }

            catch {
                Console.WriteLine("Erro! Digita apenas numeros");
            }
    }
    }

}