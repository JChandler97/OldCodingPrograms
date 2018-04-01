#include <iostream>
#include "rectangleType.h"
#include "boxType.h"
  
using namespace std; 

void boxType::setDimension(double l, double w, double h)
{
    //
	//use rectangleType to get the box dimensions
	//
	rectangleType();

    if (h >= 0)
        height = h;
    else
        height = 0;
}

double boxType::getHeight() const
{
    return height;
}

double boxType::area() const
{
    return  2 * (getLength() * getWidth()
               + getLength() * height 
               + getWidth() * height);
}

double boxType::volume() const
{
    //
	//find volume using rectangleType
	//
		area();

}

void boxType::print() const
{
	//   
	//use rectangleType to print dimensions
    //

	print();
	cout << "; Height = " << height;
}

boxType::boxType()	
{
    height = 0.0;
}

boxType::boxType(double l, double w, double h)
         : rectangleType(l, w)
{ 
    if (h >= 0)
        height = h;
    else
        height = 0;
}
