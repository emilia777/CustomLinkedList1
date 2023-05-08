using CustomLinkedLis
 

﻿using LinkedList;
using System.Collections.Generic;
using System.Runtime.InteropServices;

CustomLinkedList list = new CustomLinkedList();
list.AddAfter(0);
list.AddAfter(1);
list.AddBefore(3);
list.RemoveAtAfter(1);
list.RemoveBefore(0);
list.Print();