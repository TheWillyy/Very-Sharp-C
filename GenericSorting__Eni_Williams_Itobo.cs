
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorter{

	///<summary>
	///The main display class.
	///This class contains the main method.
	///</summary>

	public class TheMain{
		///<summary>
		///<para>This is the Main method. It appends items to the new generic list that will be created.</para>
		///<para>Also houses the implementation of the generic </c>sortItems</c> Method.</para>
		///</summary>
		///<remarks>
		///<para>This method creates a <c>someItems</c> list with a Generic <c/>double</c> Type, appends items into it and creates an instance of a Sortable List which is initialized with the <c>someItems</c> List.</para>
		///</remarks>

		public void Main(string[] args){
			Console.WriteLine("It Works!");
			List<char> someItems = new List<char>();
			someItems.Add('f');
			someItems.Add(4);
			someItems.Add('g');
			someItems.Add(8);
			someItems.Add(2);
			Sortable<char> mainSortableList = new Sortable<char>(someItems);
			mainSortableList.sortItems();
		}
	}

	///<summary>
	///<para>This is the <c>SortableList</c> Class</para>
	///<para>It houses the generic </c>sortItems</c> Method.</para>
	///</summary>
	///<remarks>
	///This method creates a <c>someItems</c> list with a Generic <c/>double</c> Type, appends items into it and creates an instance of a Sortable List which is initialized with the <c>someItems</c> List.
	///</remarks>

	///<list>
	///<item>sortItems</item>
	///<description>Sorts items in a list with a generic type using the insertion technique.</description>
	///<returns>Nothing. Just sorts the list and leaves it modified</returns>
	///<item>CompareTo</item>
	///<description>A method in the <c>IComparable</c> Interface. It compares two items with a generic type</description>
	///<returns>0, 1 or -1</returns>
	///<item>Count</item>
	///<description>Sorts items in a list with a generic type</description>
	///<returns>The length of the list where it is used as a dot function with.</returns>
	///<example>
		///<code>
			///List<S> sortableList
			///sortableList.Count()
		///</code>
	///</example>
	///</list>
	class Sortable<S> where S : IComparable<S>{
		///<value>The list in the class that will be use to carry out the sorting</value>
		public List<S> sortableList;

		///<summary>This is the constructor of the <c>Sortable</c> class.</summary>
		///<param><c>f</c> is the unsorted list the will be used to instantiate a new instance of the class <c>Sortable</c></param>
		public Sortable(List<S> f){
			this.sortableList = f;
		}
		//constructor for the Generic "Sortable Class"

		///<summary>This method sorts items in a list with a generic type using the insertion technique.</summary>
		///<returns>Nothing. Just sorts the list and leaves it modified</returns>
		//inner insertion sort mechanism

		///<value>
		public void sortItems(){
			for(int curr = 1; curr<this.sortableList.Count(); curr++){
				var key = this.sortableList[curr];
				int prev=curr-1;

				while(prev >= 0 && (this.sortableList[prev].CompareTo(key) !=0 && this.sortableList[prev].CompareTo(key) !=-1)){
					this.sortableList[prev + 1] = this.sortableList[prev];
					prev -= 1;
				}

				this.sortableList[prev + 1] = key;
			}

			///<summary>This block prints each item from the sorted list.</summary>
			///<returns>Each item from the sorted list one by one.</returns>
			foreach (object o in this.sortableList){
				Console.WriteLine(o);
			}
		}
	} 
}




