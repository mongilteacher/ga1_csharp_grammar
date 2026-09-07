using UnityEngine;

public class StructExample : MonoBehaviour
{
    private void Start()
    {
        Point point = new Point(2, 2);
        point.X = 3;
        
        Debug.Log($"좌표(x: {point.X}, y:{point.Y})]");
        
        // - 구조체는 값형이고,
        // - 클래스(객체)는 참조형입니다.

        Person person1 = new Person("홍준순", 24, 123f, 23d, false);
        Person person2 = person1;

        person2._name = "김예찬";
        
        Debug.Log(person1._name);  // 홍준순 vs 김예찬
        
        Point point1 = new Point(2, 2);
        Point point2 = point1;
        point2.X = 3;
        
        Debug.Log(point1.X);   // 2 vs 3


        int number1 = 3;
        int number2 = number1;
        number2 = 5;

        Debug.Log(number1);  // 3 vs 5


        Point left = new Point(-1, 0);
        Point zero = Point.Zero();
        Point right = new Point(1, 0);
        
        // static ㅇ

    }
    
}
