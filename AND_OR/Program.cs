﻿//2. Math >=90 OR Chemistry >=90, Biology >=90; - ainult ÜKS nendest tingimustest peab olema täidetud, et kooli sisse saada

int math, biology, chemistry;

Console.WriteLine("Enter your Math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology result:");
biology = Int32.Parse(Console.ReadLine());

if((math >= 90 && biology >= 90) || (math >= 90 && biology >= 90) || (chemistry >= 90 && biology >= 90))
{
    Console.WriteLine("Congratiolations! You got accepted");
}
else
{
    Console.WriteLine("Your application cannot be approved.");
}