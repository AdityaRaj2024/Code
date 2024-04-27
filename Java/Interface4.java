package mypack;
interface Printable
{
    void print();
}
interface Showable extends Printable
{
    void show();
}
class Interface4 implements Showable
{
    public void print()
    {
        System.out.println("Hello");
    }
    public void show()
    {
        System.out.println("Welcome");
    }
    public static void main(String args[])
    {
        Interface4 obj = new Interface4();
        obj.print();
        obj.show();
    }
}