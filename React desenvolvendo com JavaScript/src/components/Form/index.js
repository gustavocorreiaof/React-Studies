import './Form.css'
import TextField from '../TextField'

const Form = () => {
    return (
        <section className='formulario'>
            <form >
                <h2>Preencha os dados para criar o card do colaboraror.</h2>

                <TextField Label='Nome' PlaceHolder='Digite seu Nome' />
                <TextField Label='Cargo' PlaceHolder='Digite seu cargo' />
                <TextField Label='Imagem' PlaceHolder='Digite o endereço da imagem' />
            </form>
        </section>
    )
}

export default Form