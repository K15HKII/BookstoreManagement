using System.Windows.Media;
using System.Windows.Shapes;

namespace BookstoreManagement.Components
{
    public class Ticket : Shape
    {
        protected override Geometry DefiningGeometry => GetGeometry();

        private Geometry GetGeometry()
        {
            return Geometry.Parse("M 100, 0 l 100, 100 l -100, 100 l -100, -100 Z");
        }
    }
}
