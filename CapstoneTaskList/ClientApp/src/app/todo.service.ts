import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { ToDoItem } from './ToDoItem';

@Injectable({
  providedIn: 'root'
})
export class TodoService {
url: string = "ToDoList"
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) { 
    this.url = baseUrl + this.url;
  }
  GetToDoList(): Observable<any>{
    return this.http.get(this.url)
  }
  GetToDo(id: number){
    return this.http.get(this.url + "/GetToDo/" + id);
  }
  InsertToDo(tdi: ToDoItem){
    return this.http.post(this.url + "/CreateToDo",tdi)
  }
  UpdateToDo(tdi: ToDoItem){
    return this.http.put(this.url + "/UpdateToDo",tdi)
  }
  DeleteToDo(id: number){
    return this.http.delete(this.url + "/DeleteToDo/" + id);
  }
}
