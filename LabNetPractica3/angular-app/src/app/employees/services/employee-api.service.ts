import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import Employee from '../models/employees';


@Injectable({
  providedIn: 'root'
})
export class EmployeeApiService {

  private apiUrl = 'http://localhost:64553/api/Employee';

  constructor(private http: HttpClient) { }

  getEmployees(): Observable<Employee[]> {
    return this.http.get<Employee[]>(this.apiUrl);
  }

  getEmployeeById(id: number): Observable<Employee> {
    const url = `${this.apiUrl}/${id}`;
    return this.http.get<Employee>(url);
  }

  createEmployee(newEmployee: Employee): Observable<Employee> {
    return this.http.post<Employee>(this.apiUrl, newEmployee);
  }

  updateEmployee(updatedEmployee: Employee): Observable<Employee> {
    const url = `${this.apiUrl}/${updatedEmployee.Id}`;
    return this.http.put<Employee>(url, updatedEmployee);
  }

  deleteEmployee(employeeId: number): Observable<void> {
    const url = `${this.apiUrl}/${employeeId}`;
    return this.http.delete<void>(url);
  }
}
