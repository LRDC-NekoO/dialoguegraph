using UnityEngine;
using System.Collections.Generic;
using System;

[Serializable]
public class CSVTable
{
	[Serializable]
	public class Row
	{
		public string ID;
		public string KEY;
		public string FR;
		public string EN;
		public string SP;
		public string IT;
	}

	List<Row> rowList = new List<Row>();
	bool isLoaded = false;

	public bool IsLoaded()
	{
		return isLoaded;
	}

	public List<Row> GetRowList()
	{
		return rowList;
	}

	public void Load(TextAsset csv)
	{
		rowList.Clear();
		string[][] grid = CsvParser2.Parse(csv.text);
		for(int i = 1 ; i < grid.Length ; i++)
		{
			Row row = new Row();
			row.ID = grid[i][0];
			row.KEY = grid[i][1];
			row.FR = grid[i][2];
			row.EN = grid[i][3];
			row.SP = grid[i][4];
			row.IT = grid[i][5];

			rowList.Add(row);
		}
		isLoaded = true;
	}

	public int NumRows()
	{
		return rowList.Count;
	}

	public Row GetAt(int i)
	{
		if(rowList.Count <= i)
			return null;
		return rowList[i];
	}

	public Row Find_ID(string find)
	{
		return rowList.Find(x => x.ID == find);
	}
	public List<Row> FindAll_ID(string find)
	{
		return rowList.FindAll(x => x.ID == find);
	}
	public Row Find_KEY(string find)
	{
		return rowList.Find(x => x.KEY == find);
	}
	public List<Row> FindAll_KEY(string find)
	{
		return rowList.FindAll(x => x.KEY == find);
	}
	public Row Find_FR(string find)
	{
		return rowList.Find(x => x.FR == find);
	}
	public List<Row> FindAll_FR(string find)
	{
		return rowList.FindAll(x => x.FR == find);
	}
	public Row Find_EN(string find)
	{
		return rowList.Find(x => x.EN == find);
	}
	public List<Row> FindAll_EN(string find)
	{
		return rowList.FindAll(x => x.EN == find);
	}
	public Row Find_SP(string find)
	{
		return rowList.Find(x => x.SP == find);
	}
	public List<Row> FindAll_SP(string find)
	{
		return rowList.FindAll(x => x.SP == find);
	}
	public Row Find_IT(string find)
	{
		return rowList.Find(x => x.IT == find);
	}
	public List<Row> FindAll_IT(string find)
	{
		return rowList.FindAll(x => x.IT == find);
	}

}