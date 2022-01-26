import { Component, Input, OnInit } from '@angular/core';
import { TodoService } from '../todo.service';
import { ToDoItem } from '../ToDoItem';
@Component({
  selector: 'app-edit-todo',
  templateUrl: './edit-todo.component.html',
  styleUrls: ['./edit-todo.component.css'],
  providers: [TodoService]
})
export class EditTodoComponent implements OnInit {
@Input() Id: number;
  toDo?: ToDoItem;

  constructor(private toDoService: TodoService) { 
    this.toDoService.GetToDo(this.Id).subscribe(
      (response: any)=> {this.toDo = response;}
    )
  }
  UpdateItem(id: number){
    let assd = (<HTMLInputElement>document.getElementById("tm")).value;
    let sdes = (<HTMLInputElement>document.getElementById("shortDescription")).value;
    let dd = (<HTMLInputElement>document.getElementById("dateTime")).value;
    let newItem: ToDoItem = {id:this.Id,tm:assd,shortDescription:sdes,dueDate:dd,completed:false};
    this.toDoService.UpdateToDo(newItem).subscribe(
      (response: any) =>{location.reload()}
    );
  }
  ngOnInit() {
  }

}
