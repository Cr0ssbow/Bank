using System;

namespace MyLib
{
 
  public class ClassAcc
  {
       public delegate void Account(string massage);
       public delegate void Event(ClassAcc a, EventAcc b);
       public event Event Notify;
       Account acc;
       private string fio;
       private int sum;
       public int Sum { get => sum; set => sum = value; }
       public string Fio { get => fio; set => fio = value; }
       public void Processing(Account del)
       {
            acc = del;
       }
       public void AccClass(int sum, string fio)
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
            acc?.Invoke($"Списание {sum} со счёта произошло успешно. Ваш баланс: {Sum} рублей.");
            Notify?.Invoke(this, new EventAcc($"Списание со счёта {sum}",sum));
       }
       public void Plase(int sum)
       {
            Sum += sum;
            acc?.Invoke($"Зачисление {sum} на счёт произошло успешно. Ваш баланс: {Sum} рублей.");
            Notify?.Invoke(this, new EventAcc($"Зачисление {sum} рублей", sum));
       }
        public class EventAcc
        {
            public string Massage { get; }
            public int Sum { get; }
            public EventAcc(string massage, int sum)
            {
                Massage = massage;
                Sum = sum;
            }
        }
  }
}
