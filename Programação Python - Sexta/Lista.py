import flet as ft

def main(page: ft.Page):
    
    # Função para adicionar um novo item à lista
    def add_item(e):
        if new_item_text.value:
            items_list.controls.append(
                ft.ListTile(
                    title=ft.Text(new_item_text.value),
                    subtitle=ft.Text("Sem Elenco"),
                    trailing=ft.IconButton(
                        icon=ft.icons.EDIT,
                        on_click=lambda e, item=new_item_text.value: edit_item(item)
                    ),
                    on_click=lambda e: display_item_details(e.control.title, e.control.subtitle),
                )
            )
            new_item_text.value = ""
            page.update()

    # Função para editar um item existente
    def edit_item(item):
        dialog = ft.AlertDialog(
            title=ft.Text(f"Editando: {item}"),
            content=ft.TextField(label="Novo Elenco", value=""),
            actions=[
                ft.TextButton(
                    text="Salvar",
                    on_click=lambda e: save_item_details(e, item)
                ),
                ft.TextButton(
                    text="Cancelar",
                    on_click=lambda e: dialog.close(),
                ),
            ],
        )
        page.dialog = dialog
        dialog.open = True
        page.update()

    # Função para salvar as edições de um item
    def save_item_details(e, item):
        for tile in items_list.controls:
            if tile.title.value == item:
                tile.subtitle.value = e.control.parent.content.value
        page.dialog.open = False
        page.update()

    # Função para exibir detalhes de um item
    def display_item_details(title, subtitle):
        item_details.value = f"Time: {title.value}\nElenco: {subtitle.value}"
        page.update()

    new_item_text = ft.TextField(label="Novo Time", width=300)
    add_button = ft.IconButton(icon=ft.icons.ADD, on_click=add_item)
    items_list = ft.ListView(expand=1, padding=10)
    item_details = ft.Text(value="Selecione um time para ver detalhes", expand=1)

    page.add(
        ft.Row([new_item_text, add_button]),
        items_list,
        item_details
    )

ft.app(target=main)
