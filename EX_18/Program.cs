bool x = true; 
bool y = false; 
bool resleft = false; 
bool resright = false; 
bool LogNO(bool znach) 
{ 
    if (znach == true) znach = false; 
    else znach = true; 
    return znach; 
} 
bool LogAnd(bool zn1, bool zn2, bool result) 
{ 
    if (zn1 && zn2 == true) result = true; 
    else result = false; 
    return result; 
} 
bool LogOr(bool znach1, bool znach2, bool output) 
{ 
    if (znach1 || znach2 == true) output = true; 
    else output = false; 
    return output; 
} 
LogOr(x, y, resleft); 
LogNO(resleft); 
LogNO(x); 
LogNO(y); 
LogAnd(x, y, resright); 
global::System.Console.WriteLine(resleft == resright);