using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveOnBoardGame.Enums
{
    enum MoveDirection
    {
        MOVE_UP = 'w', //Jeżeli mamy const (stała, nie można jej zmienić), to nazwe piszemy z dużych liter (zamiast moveUp będzie MOVE_UP, itd.)
        MOVE_DOWN = 's',
        MOVE_RIGHT = 'd',
        MOVE_LEFT = 'a',
    }
}
