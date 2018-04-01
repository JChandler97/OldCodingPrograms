#include <iostream>
#include <string>
#include <iomanip>

using namespace std;

class userApp {
  public:  
    void setInfo(string, string, int);
    void modifyInfo(string&, string&, int&);
    void showInfo(string&, string&, int&);   
    void appBuy(int&, float&);
    float amountCount();
    
  private:
    int appSold;
    int appToSell;
    int appTotal;
    int appToBuy;
    float amountSpent;
    int amountReceive;
    double cost;
    int amount;
    int ID;
    string first;
    string last;
    
};

