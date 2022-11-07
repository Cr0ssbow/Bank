using System;

namespace MyLib
{
  public class AccEvent
  {
    public string Massage { get;}
    public int sum { get;}
    public AccEvent(string massage, int sum)
    {
      Massage = massage;
      Sum = sum;
    }
  }
  public class Account
  {
       public delegate void Acc(string massage);
       public delegate void Event(Acc a, AccEvent b);
       public event Event Notify;
       Acc account;
       public int Sum { get => sum; set => sum = value; }
       public string Fio { get => fio; set => Fio = value; }
       public void Processing(Acc del)
       {
            account = del;
       }
       public void AccountClass(int sum, string fio)
       {
            Fio = fio;
            Sum = sum;
       }
       public void TakeOff(int sum)
       {
            if (Sum >= sum )
            {
                Sum -= sum;
            }
            acc?.Invoke($"Списание со счёта произошло успешно. Ваш баланс: {Sum} рублей.");
            Notify?.Invoke(this, new AccEvent($"Списание со счёта {sum}",sum));
            else (Sum <= sum);
            {
                acc?.Invoke($"Недостаточно средств. Ваш баланс: {Sum} рублей.");
                Notify?.Invoke(this, new AccEvent($"Недостаточно средств {sum}", sum));
            }
       }
  }
}
