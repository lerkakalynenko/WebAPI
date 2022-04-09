namespace WebApiTest.Models
{
    public class TextHandler
    {
        public string Calculate(float name1, float name2)
        {
            var res = name1 + name2;
            
            return $"{name1} + {name2} = {res}";
        }
    }
}
