using System;

delegate int Op(int n1, int n2);

public class Mat {
        public static int soma(int n1, int n2) {
            return n1 + n2;
        }

        public static int mult(int n1, int n2) {
            return n1 * n2;
        }


}

public class Aula50 {
    public static void Main() {

        int res;


        Op d1 = new Op(Mat.soma);
        res = d1(50, 10);
        Console.WriteLine("Soma: {0}", res);
        
        d1 = new Op(Mat.mult);
        res = d1(10, 50);
        Console.WriteLine("Multiplicação: {0}", res);

    }
}