# ToDo-API
1) Реализовать модель Users со следующими свойствами: <br />
  Id (Guid)<br />
  Name (string)<br />
  Age (string)<br />
  Email (bool)<br />
А также модель Task со следующими свойствами: <br />
  ID (Guid)<br />
  Title (string)<br />
  Description (string)<br />
  Status (Enum: "To Do", "In Progress", "Done")<br />
  CreatedAt (DateTime)<br />
  UpdatedAt (DateTime)<br />
  DueDate (DateTime)<br />
  UserID (Guid)<br />
2) Создайть контроллер UsersController с следующими эндпоинтами:<br />
  GET /api/users - получить всех пользователей<br />
  GET /api/users/{id} - получить пользователя по id<br />
  POST /api/users - создать нового пользователя<br />
  PUT /api/users/{id} - обновить пользователя по id<br />
  DELETE /api/users/{id} - удалить пользователя<br />
3)Создайть контроллер TaskController:<br />
  GET /api/tasks - получить список всех задач<br />
  GET /api/tasks/{id} - получить конкретную задачу по ID<br />
  POST /api/tasks - создать новую задачу<br />
  PUT /api/tasks/{id} - обновить существующую задачу<br />
  DELETE /api/tasks/{id} - удалить задачу<br />
3.1) Дополнить контроллер пользователей(Users):<br />
  GET /api/users/{id}/tasks - получить все задачи конкретного пользователя
