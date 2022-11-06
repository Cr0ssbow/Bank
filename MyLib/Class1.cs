using System;

namespace MyLib
{
  public class Account
  {
       public delegate void Acc(string massage);
       public delegate void Event(Acc sender, AccEvent e);
       public event Event Notify;
       Acc account;
       public int Sum { get => sum; set => sum = value; }
       public string Fio { get => fio; set => Fio = value; }
       public void Processing(Acc del)
        {
            account = del;
        }
       public void AccountClass(int sum, string fio)
       


  }
}
