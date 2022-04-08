using System.Diagnostics;

abstract class Event: IComparable<Event>
{
    protected Event(int time)
    {
        Time = time;
    }

    public abstract void DoAction(PostOffice postOffice);

    public int CompareTo(Event other)
    {
        int result = Time.CompareTo(other.Time);
        if (result != 0)
            return result;

        /* Higher priority first.  */
        return -Priority.CompareTo(other.Priority);
    }

    public int Time { get; }

    public abstract int Priority { get; }
}

class NewCustomerEvent : Event
{
    public NewCustomerEvent(int time): base(time)
    {
    }

    public override int Priority => 1;

    public override void DoAction(PostOffice postOffice)
    {
        postOffice.AddCustomer(Time);
    }
}

class CustomerServedEvent: Event
{
    public CustomerServedEvent(int time): base(time)
    {
    }

    public override int Priority => 2;

    public override void DoAction(PostOffice postOffice)
    {
        postOffice.FinishServing(Time);
        postOffice.TryNextCustomer(Time);
    }
}

// TODO: implement CloseOfficeEvent

class Customer
{
    static int counter = 1;

    public Customer()
    {
        Id = counter++;
    }

    public int Id;
}

class PostOffice
{
    readonly Queue<Customer> customers = new();
    readonly SortedSet<Event> calendar = new();

    readonly bool opened = true;
    int emptyDesks = 1;

    public PostOffice()
    {
        Schedule(new NewCustomerEvent(0));
    }

    public void Schedule(Event ev)
    {
        calendar.Add(ev);
    }

    public void AddCustomer(int time)
    {
        Customer cust = new Customer();
        customers.Enqueue(cust);
        Console.WriteLine($"{time}: Adding new customer #{cust.Id} to queue ({customers.Count} items)");

        Schedule(new NewCustomerEvent(time + 5));

        if (opened)
            TryNextCustomer(time);
    }

    public void TryNextCustomer(int time)
    {
        // TODO: maybe check if we are still opened?

        if (customers.Any() && emptyDesks >= 1)
        {
            emptyDesks -= 1;
            var cust = customers.Dequeue();
            Console.WriteLine($"{time}: Serving customer #{cust.Id}");
            Schedule(new CustomerServedEvent(time + 6));
        }
    }

    public void FinishServing(int time)
    {
        Console.WriteLine($"{time}: finished serving a customer");
        emptyDesks++;
        TryNextCustomer(time);
    }

    public void Run()
    {
        while (calendar.Count > 0)
        {
            Event ev = calendar.Min;
            Misc.Log($"{ev.Time}: processing event {ev.GetType()}", ConsoleColor.Yellow);
            calendar.Remove(ev);
            ev.DoAction(this);

            // TODO: use proper CloseOfficeEvent and use opened variable
            Debug.Assert(ev.Time < 100);
        }
    }
}