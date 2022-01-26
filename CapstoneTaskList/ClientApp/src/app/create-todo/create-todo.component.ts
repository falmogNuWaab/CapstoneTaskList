import { Component, OnInit } from '@angular/core';
import { TodoService } from '../todo.service';
import { ToDoItem } from '../ToDoItem';

import { TodoListComponent } from '../todo-list/todo-list.component';
@Component({
  selector: 'app-create-todo',
  templateUrl: './create-todo.component.html',
  styleUrls: ['./create-todo.component.css'],
  providers: [TodoService]
})
export class CreateTodoComponent implements OnInit {

  constructor(private todoService: TodoService) { }

  createItem(){
    let assd = (<HTMLInputElement>document.getElementById("tm")).value;
    let sdes = (<HTMLInputElement>document.getElementById("shortDescription")).value;
    let dd = (<HTMLInputElement>document.getElementById("dateTime")).value;
    let newItem: ToDoItem = {id:0,tm:assd,shortDescription:sdes,dueDate:dd,completed:false};
    this.todoService.InsertToDo(newItem).subscribe(
      (response: any) =>{location.reload()}
    );
  }
  ngOnInit() {
  }

}
