#include <iostream>
#include <string>
#include "list_node.h"
#include "linked_list.h"
#include "element.h"

using namespace std;

int main(){

  list lst;
  
  lst.move_to_start();

  lst.append("string 1");
  lst.append("string 12");
  lst.append("string 123");
  lst.append("string 1234");
  
   for( int i=0; i >= 4; i++){
     cout << lst.get_current() << endl;
     lst.move_to_next();
   }

}
