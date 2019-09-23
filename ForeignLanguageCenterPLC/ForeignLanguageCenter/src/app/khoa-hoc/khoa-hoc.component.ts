import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { SelectionModel } from '@angular/cdk/collections';

export interface CourseElement {

  name: string;
  time: string;
  status: number;
  price: string;
}




@Component({
  selector: 'app-khoa-hoc',
  templateUrl: './khoa-hoc.component.html',
  styleUrls: ['./khoa-hoc.component.css']
})
export class KhoaHocComponent implements OnInit {

  ELEMENT_DATA: CourseElement[] = [
    {  name: 'Toiec', time: '6 Tháng', status: 1, price: '1.000.000' },
    {  name: 'Ielts', time: '12 Tháng', status: 1, price: '6.000.000' },
    {  name: 'Anh văn cơ bản', time: '3 Tháng', status: 0, price: '250.000' },

  ];

  changeStatus(statusCode: number){
    if(statusCode == 1)
    {
      return 'Hoạt động';
    }
    else{
      if(statusCode == 0){
        return 'Khóa';
      }
      else
      {
        return 'Tạm ngưng';
      }
    }
  }
  constructor() { }

  ngOnInit() {
  }

  displayedColumns: string[] = ['select', 'name', 'time', 'status', 'price'];
  dataSource = new MatTableDataSource<CourseElement>(this.ELEMENT_DATA);
  selection = new SelectionModel<CourseElement>(true, []);

  /** Whether the number of selected elements matches the total number of rows. */
  isAllSelected() {
    const numSelected = this.selection.selected.length;
    const numRows = this.dataSource.data.length;
    return numSelected === numRows;
  }

  /** Selects all rows if they are not all selected; otherwise clear selection. */
  masterToggle() {
    this.isAllSelected() ?
      this.selection.clear() :
      this.dataSource.data.forEach(row => this.selection.select(row));
  }

  /** The label for the checkbox on the passed row */
  checkboxLabel(row?: CourseElement): string {
    if (!row) {
      return `${this.isAllSelected() ? 'select' : 'deselect'} all`;
    }
    return `${this.selection.isSelected(row) ? 'deselect' : 'select'} row ${row.name + 1}`;
  }



}
