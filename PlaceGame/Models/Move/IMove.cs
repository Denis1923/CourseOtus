using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceGame.Models
{
    public interface IMove
    {
        Vector GetVelocity();
        Vector GetLocation();
        void SetLocation(Vector vector);
    }
}
