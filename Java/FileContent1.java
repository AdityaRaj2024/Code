// Java program to display all the contents of a directory
package mypack;
import java.io.*;
class FileContent1
{
    public static void main(String args[]) throws IOException
    {
        DataInputStream ds = new DataInputStream(System.in);
        System.out.println("Enter dirpath:");
        String dirpath = ds.readLine();
        System.out.println("Enter the dirname");
        String dname = ds.readLine();
        File f = new File(dirpath, dname);
        if(f.exists())
        {
            String arr[] = f.list();
            int n = arr.length;
            for (int i = 0; i < n; i++)
            {
                System.out.println(arr[i]);
                // File f1 = new File(arr[i]);
                // if (f1.isFile())
                    // System.out.println(": is a file");
                // if (f1.isDirectory())
                    // System.out.println(": is a directory");
            }
            System.out.println("No of entries in this directory " + n);
        }
        else
            System.out.println("Directory not found");
    }
}