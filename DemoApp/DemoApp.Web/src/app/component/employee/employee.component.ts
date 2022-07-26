import { Component, Input, OnInit } from '@angular/core';
import { EmployeeService } from 'src/app/_service/employee.service';
// import { EmployeeService } from 'src/_service/employee.service';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {
  @Input() item: any;
  // public data: any = [];  
  
  constructor(
    private employeeService : EmployeeService
    ) {}

  ngOnInit(): void { 
    console.log("Test")
    // this.employeeService.sendGetRequest().subscribe((responseBody) => {
    //   console.log(responseBody);
    // });
    // this.employeeService.sendGetRequest()
    // .subscribe(data => {
    //   console.log(data)
    // });  
    this.employeeService.getEmployees()
    .subscribe( data => 
      console.log(data)) 
  } 
}