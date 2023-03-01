import java.util.Scanner;

public class Fibonacci {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Digite um inteiro:");
        int num = sc.nextInt();
        
        boolean ehFibo = testaFibonacci(num);
        
        if(ehFibo){
            System.out.println("É fibonacci");
        } else {
            System.out.println("Não é fibonacci");
        }
    }
    
    public static boolean testaFibonacci(int num){
        
        if(num == 0){
            return true;
        }
        
        int soma = 1;
        for(int a, b = 1; soma<num; soma = a + b){
            a = b;
            b = soma;
        }
        
        if(soma == num){
            return true;
        } 
        
        return false;
    }
}