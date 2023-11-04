package prime_number;

import java.util.Scanner;

public class PrimeNumber {
    public static void main(String[] args) {
        System.out.println("Enter a number!!!");
        Scanner input = new Scanner(System.in);
        int input_number = input.nextInt();
        boolean divided = false;
        for (int i = 2; i <= input_number; i++) {
            for (int j = 2; j <= i / 2; j++) {
                if (i % j == 0 & i != j) {
                    divided = true;
                    break;
                }


            }
            if (divided == false) {
                System.out.println(i + " is a prime number.");
            }
            divided = false;
        }
    }
}
