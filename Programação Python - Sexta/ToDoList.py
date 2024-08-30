import flet as ft
from flet import(
    Checkbox,
    Column,
    FloatingActionButton,
    IconButton,
    OutlinedButton,
    Page,
    Row,
    Tab,
    Text,
    TextField,
    UserControl,
    colors,
    icons,
    #importação dos componentes necessários
)

#classe principal de tarefa
class Task(UserControl):
    def __init__(self, task_name, task_status_change, task_delete): #adicionar nome, mudar e deletar a tarefa
        super().__init__()
        self.completed= False  #a tarefa começa não completada
        self.task_name= task_name
        self.status= task_status_change
        self.delete= task_delete

#classe da aplicação toda
class TodoApp(UserControl):
    def build(self):
        self.new_task= TextField(
            hint_text= "Escreva a tarefa que deseja adicionar...",
            expand= True
        )
    
#função principal
def main(page: Page):
    page.title= "Tarefas"
    page.horizontal_alignment= "center"
    page.scroll = "adaptive"
    page.update()

#instancia a classe principal
    app = TodoApp()

#adiciona a aplicação à página 
    page.add(app)

ft.app(target= main)