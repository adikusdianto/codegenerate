using System;
namespace Zeus.Data
		internal SimpleColumnCollection(SimpleTable table)
		public SimpleColumn this[int columnIndex] 
		{
			{
				{
					index = i;
				}
		public void Remove(string columnName) 
		public void RemoveAt(int columnIndex) 
		public void Add(string columnName) 
			{
		public void Insert(int insertIndex, string columnName) 
			{
	internal delegate void SimpleColumnEventHandler(ColumnEventType type, int index);
	internal enum ColumnEventType