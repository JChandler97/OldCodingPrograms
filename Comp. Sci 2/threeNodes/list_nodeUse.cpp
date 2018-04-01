#include <iostream>
#include <string>
#include <iomanip>
#include <fstream>
#include "list_node.h"
#include "element.h"

using namespace std;

int main()
{
	int count = 0;
	string name = "Julie";
	string last = "Mansfield";
	string fnode;
	string middle = "Edlund";
	string snode;
	string tnode;
        list_node *head;
	list_node *tail;
	list_node *temp;	
	list_node *fnodePtsTo;
	list_node *snodePtsTo;
	list_node *tnodePtsTo;

	list_node myNode(name);
	count = count +1;
	list_node lName(last);
	count = count + 1;
	list_node mName(middle);
	count = count + 1;

	cout << "I now have " << count << " nodes in my list." << endl;

	
	fnode = myNode.get_item();	// data in first node
	snode = lName.get_item(); 	//data for node 2
	tnode = mName.get_item(); 	//data for 3

	head = &myNode;// beginning of list
	cout << "the head of my list is the value of this pointer which points to the first list item as a stand alone pointer " << head << endl;

	tail  = myNode.get_next();
	cout << " one node in the list, pointed to by the value head and the value of the pointer part of this first node is NULL " << tail << endl;

//	cout << "the datum in myNode " << fnode << endl;
// one node with head pointing to it and it has null in the ptr in it so it is tail
// take the newnode that is lName and point to it then move the value of the pointer to lName into the pointer area of myNode - so myNode points to lName
// assign the point value that points to the new node to a temp pointer so you can put it in the myNodes pointer area so myNode pts to lName
// nodes are already made - we are now hooking them together into a linked list by using the pointer part of the nodes to make a list
	// the pointer value that is created when you make your second node is now retrieved using & and that value will be moved into the pointer section of the first node

	temp = &lName;
	myNode.put_next(temp);
	temp = &mName;
	lName.put_next(temp);	

// after pointing the new value in myNode assign that value so you can get that value and print it - notice it is a value returning function
//	FIRST NODE


	fnodePtsTo = myNode.get_next(); 
	cout << "after assigning myNode pointer the value from the new pointer for lName " << endl;
	cout << "myNode pointer value " << fnodePtsTo << endl;
	temp = &mName;
	snodePtsTo = lName.get_next();

// myNode should now have the head pointer pointing at it and its pointer pointing to lName node
// lName node should have null in it's pointer value
// 	SECOND NODE


	snode = lName.get_item();
	cout << " value in lName " << snode << endl;
	cout << "the pointer value of head still pointing at myNode " <<head << endl;
        cout << "the pointer value of tail which is now from the lName node pointer " <<tail << endl;

// now we will change the null value in node 2 so that it points to the third node - do we need to do anything to the pointer that is part of the third node? 
//	THIRD NODE


	tnodePtsTo = mName.get_next();
// we have proved all this works above with couts - so now we will list the data from the three nodes

	cout << "below are the values from each node's element (item) along with the value stored in each of the node's pointer " << endl;
	cout << fnode << " " << fnodePtsTo << endl;	
	cout << snode << " " << snodePtsTo << endl;
	cout << tnode << " " << tnodePtsTo << endl;
	cout << count << endl;


// ANYTHING AFTER HERE IS EXPLOSIVE

	head = myNode.get_next();
	count = count - 1;
	count = count - 1;	
		
	cout << head << endl;
			
	return 0;

}
