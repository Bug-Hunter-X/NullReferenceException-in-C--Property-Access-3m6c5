public class ExampleClass
{
    public int? MyProperty { get; set; } //Nullable int

    public void MyMethod()
    {
        //Safe null check before accessing property
        Console.WriteLine(MyProperty.HasValue ? MyProperty.ToString() : "MyProperty is null"); 
    }
}