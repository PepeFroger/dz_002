using System;
Random rnd = new Random();
int N = 5;
int M = 5;
int[,] mas = new int[N,M];
for (int i=0; i<N;i++){
    for(int j=0;j<M;j++){
        mas[i,j] = rnd.Next(-100,100);
        Console.Write($"{mas[i,j]}\t");
    }
    Console.WriteLine();
}
int temp;
Console.WriteLine();
for (int i=0; i<N;i++){
    temp = mas[0,i];
    mas[0,i] = mas[M-1,i];
    mas[M-1,i] = temp;
}
for (int i=0; i<N;i++){
    for(int j=0;j<M;j++){
        Console.Write($"{mas[i,j]}\t");
    }
    Console.WriteLine();
}
