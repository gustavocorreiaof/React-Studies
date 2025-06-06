import './Form.css'
import TextField from '../TextField'
import OverHeadList from '../OverHeadList/Index'
import Button from '../Button/Index'
import { useState } from 'react'

const Form = (props) => {

    const times = [
        'Programação',
        'Front-end',
        'Data Science',
        'Devops',
        'Ux e Design',
        'Mobile',
        'Inovação e Gestão'
    ]

    const aoSalvar = (event) => {
        event.preventDefault()
        props.aoColaboradorCadastrado({
            nome,
            cargo,
            imagem,
            time
        })
    }

    const [nome, setNome] = useState('')
    const [cargo, setCargo] = useState('')
    const [imagem, setImagem] = useState('')
    const [time, setTime] = useState('')

    return (
        <section className='formulario'>
            <form onSubmit={aoSalvar}>
                <h2>Preencha os dados para criar o card do colaboraror.</h2>



                <TextField aoAlterado={ valor => setNome(valor)} required={true} Label='Nome' valor={nome} PlaceHolder='Digite seu Nome' />
                <TextField aoAlterado={ valor => setCargo(valor)} required={true} Label='Cargo' valor={cargo} PlaceHolder='Digite seu cargo' />
                <TextField aoAlterado={ valor => setImagem(valor)} required={false} Label='Imagem' valor={imagem} PlaceHolder='Digite o endereço da imagem' />
                <OverHeadList Label='Time' itens={times} required={true} valor={time} aoAlterado={valor => setTime(valor)} ></OverHeadList>
                <Button>Criar Card</Button>
            </form>
        </section>
    )
}

export default Form