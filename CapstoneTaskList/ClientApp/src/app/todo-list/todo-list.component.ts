import { Component, OnInit } from '@angular/core';
import { TodoService } from '../todo.service';
import { ToDoItem,Convert } from '../ToDoItem';

@Component({
  selector: 'app-todo-list',
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.css'],
  providers: [TodoService]
})
export class TodoListComponent implements OnInit {
  toDos: ToDoItem[] = [];
  //json: string;
  constructor(private todoService: TodoService) { 
    this.todoService.GetToDoList().subscribe(
      (response: any) => {this.toDos = response}
    )
    
    console.log(this.toDos);
  }
  DeleteToDoItem(id: number){
    this.todoService.DeleteToDo(id).subscribe(
      (response: any)=>{location.reload()}
    );
  }
  ngOnInit() {
  }

}
