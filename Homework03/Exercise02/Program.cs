// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

//int[] massive = {3, 6, 8, 2, 1, -7};
int[] massive = {7, -5, 0, 1, -1, 9};
double distanceX = (Math.Pow((massive[3] - massive[0]), 2)); 
double distanceY = (Math.Pow((massive[4] - massive[1]), 2));
double distanceZ = (Math.Pow((massive[5] - massive[2]), 2));
double distanceR = Math.Sqrt(distanceX + distanceY + distanceZ);
Console.WriteLine($"{distanceR:f2}");