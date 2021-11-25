using System;
namespace References
{
    interface IFlippable
    {
        int CurrentPage { get; set; }
        void Flip();
    }
}
