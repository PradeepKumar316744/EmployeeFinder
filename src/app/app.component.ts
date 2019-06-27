import { Component } from '@angular/core';
import { EmployeeService } from "../app/Services/employee.service";
import { Employee } from './Model/Employee';

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css']
})
export class AppComponent {
    title = 'EmployeeFinder';

    constructor(private employeeService: EmployeeService) { }


    testData : boolean;
    Data: Employee;
    Error: string;

    SearchEmployee() {
        this.employeeService.GetEmployeeByID()
            .subscribe(
                //p=>console.log(p),
                data => this.Data = data, // success path
                error => this.Error = error // error path
            );
    }
}
