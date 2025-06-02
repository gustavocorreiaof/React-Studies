import './Form.css'
import TextField from '../TextField'
import OverHeadList from '../OverHeadList/Index'
import Button from '../Button/Index'

const Form = () => {

    const times = [
        'Programação',
        'Front-end',
        'Data Science',
        'Devops',
        'Ux e Design',
        'Mobile',
        'Inovação e Gestão'
    ]

    return (
        <section className='formulario'>
            <form >
                <h2>Preencha os dados para criar o card do colaboraror.</h2>



                <TextField Label='Nome' PlaceHolder='Digite seu Nome' />
                <TextField Label='Cargo' PlaceHolder='Digite seu cargo' />
                <TextField Label='Imagem' PlaceHolder='Digite o endereço da imagem' />
                <OverHeadList Label='Time' itens={times} ></OverHeadList>
                <Button>Criar Card</Button>
            </form>
        </section>
    )
}

export default Form