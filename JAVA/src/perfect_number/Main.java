package perfect_number;

import java.util.ArrayList;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.print("Enter a number: ");
        ArrayList divisors = new ArrayList();

        int num = input.nextInt();
        for(int i = 1; i < num; i++) {
            if(num % i == 0) {
                divisors.add(i);
            }
        }

        int total=0;
        for(int i = 0; i < divisors.size(); i++) {
           total += (int) divisors.get(i);
        }

        if(total == num) {
            System.out.println(num + " is a perfect number.");
        } else {
            System.out.println(num + " is not a perfect number.");
        }
    }

}
