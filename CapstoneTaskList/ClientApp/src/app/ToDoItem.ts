// To parse this data:
//
//   import { Convert } from "./file";
//
//   const toDoItem = Convert.toToDoItem(json);

export interface ToDoItem {
    id:               number;
    tmId:             number;
    shortDescription: string;
    dueDate:          Date;
    completed:        boolean;
}

// Converts JSON strings to/from your types
export class Convert {
    public static toToDoItem(json: string): ToDoItem[] {
        return JSON.parse(json);
    }

    public static toDoItemToJson(value: ToDoItem[]): string {
        return JSON.stringify(value);
    }
}