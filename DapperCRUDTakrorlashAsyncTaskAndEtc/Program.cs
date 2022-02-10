﻿using DapperCRUDTakrorlashAsyncTaskAndEtc.Data;
using DapperCRUDTakrorlashAsyncTaskAndEtc.Models;
using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace DapperCRUDTakrorlashAsyncTaskAndEtc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /** GetAllAsync done
            Task.Run(async () =>
            {
                IDapper dapper = new Dapperr();

                string query = "SELECT * FROM Students";
                var students = await dapper.GetAllAsync<Student>(query, null, CommandType.Text);

                foreach (Student student in students)
                {
                    Console.WriteLine(student.Name);
                }

            });
            Console.ReadKey();
            */
            
            /** GetAsync done
            Task.Run(async () =>
            {
                IDapper dapper = new Dapperr();

                string query = "SELECT * FROM Students";
                var student = await dapper.GetAsync<Student>(query, null, CommandType.Text);

                Console.WriteLine(student.Name);

            });
              Console.ReadKey();
            */
            
            /**  UpdateAsync done
            Task.Run(async () =>
            {
                while (true)
                {
                    try
                    {
                        IDapper dapper = new Dapperr();

                        Console.WriteLine("1. O'zgartirish qilishga roziman , 2. Exit");
                        
                        int chek = int.Parse(Console.ReadLine());

                        if (chek == 1)
                        {
                            Console.WriteLine("Qaysi Id dagi studentni o'zgartirmoqchisiz");
                            long id = long.Parse(Console.ReadLine());

                            Console.WriteLine("Studentni nimasini o'zgartirmoqchisiz: ");
                            Console.WriteLine("1. Name, 2. PhoneNumber, 3. Age, 4. CourseId, 5. Exit");
                            int choose = int.Parse(Console.ReadLine());

                            if (choose == 1)
                            {
                                Console.WriteLine("Student name ni kiriting: ");
                                string Name = Console.ReadLine();
                                string query = $"update Students set Name = '{Name}' where Id = {id};";
                                await dapper.UpdateAsync<Student>(query, null);

                            }
                            else if (choose == 2)
                            {
                                Console.WriteLine("Student PhoneNumber ni kiriting: ");
                                string PhoneNumber = Console.ReadLine();
                                string query = $"update Students set PhoneNumber = '{PhoneNumber}' where Id = {id};";
                                await dapper.UpdateAsync<Student>(query, null);
                            }
                            else if (choose == 3)
                            {
                                Console.WriteLine("Student Age ni kiriting: ");
                                int Age = int.Parse(Console.ReadLine());
                                string query = $"update Students set Age = '{Age}' where Id = {id};";
                                await dapper.UpdateAsync<Student>(query, null);
                            }
                            else if (choose == 4)
                            {
                                Console.WriteLine("Student CourseId ni kiriting: ");
                                long CourseId = long.Parse(Console.ReadLine());
                                string query = $"update Students set CourseId = {CourseId} where Id = {id};";
                                await dapper.UpdateAsync<Student>(query, null);
                            }
                            else if (choose == 5)
                            {
                                break;
                            }
                        }
                        else if(chek == 2) 
                        {
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine("Sizda shundek hatolik bor iltimos qaytadan harakat qilib ko'ring :)\n\n");
                        Console.WriteLine(ex.ToString());

                        continue;
                    }

                }

            });

            Thread.Sleep(20000);
            */

            /** DeleteAsync done
            Task.Run( async () =>
            {
                IDapper dapper = new Dapperr();

                Console.WriteLine("Qaysi id dagi satrni o'chirmoqchisiz: ");
                long id =  long.Parse(Console.ReadLine());
                string query = $"DELETE FROM Students WHERE id = {id};";

                await dapper.DeleteAsync<Student>(query, null);
            });

            Thread.Sleep(7000);
            */

            /** CreateAsync done
            Task.Run(async () =>
            {
                IDapper dapper = new Dapperr();

                Console.WriteLine("Entering Name: ");
                string Name = Console.ReadLine();

                Console.WriteLine("Entering PhoneNumber: ");
                string PhoneNumber = Console.ReadLine();

                Console.WriteLine("Entering Age: ");
                int Age = int.Parse(Console.ReadLine());

                Console.WriteLine("Entering CourseId: ");
                long CourseId = long.Parse(Console.ReadLine());

                string query = "INSERT INTO Students (Name, PhoneNumber, Age, CourseId)" +
                                $"'{Name}', '{PhoneNumber}', {Age}, {CourseId}";
                await dapper.CreateAsync<Student>(query, null);

            });

            Thread.Sleep(20000);
            */

        }
    }
}
