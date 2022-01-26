// To parse this data:
//
//   import { Convert } from "./file";
//
//   const toDoItem = Convert.toToDoItem(json);



export interface ToDoItem {
    id?:               number;
    tm?:             string;
    
    shortDescription: string;
    dueDate?:          string;
    completed?:        boolean;
}

// Converts JSON strings to/from your types
export class Convert {
    public static toToDoItem(json: string): ToDoItem[] {
        return JSON.parse(json);
    }

    public static toDoItemToJson(value: any[]): string {
        return JSON.stringify(value);
    }
}