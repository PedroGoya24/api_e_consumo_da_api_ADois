import './CardHome.module.css'

const CardHome = ({ imagem, titulo, texto }) => {
    return (

            <div className="card mb-3 expansao" style={{ maxWidth: 540 }}>
                <div className="row g-0">
                    <div className="col-md-4">
                        <img
                            src={imagem}
                            className="img-fluid rounded-start w-100 h-auto mt-4 "
                            alt="..."
                        />

                    </div>
                    <div className="col-md-8">
                        <div className="card-body">
                            <h5 className="card-title">{titulo}</h5>
                            <a
                                className="card-text"
                                href="promocoes.html"
                                style={{ textDecoration: "none", color: "black" }}
                            >
                                {texto}
                            </a>
                        </div>
                    </div>
                </div>
            </div>
    
    )
}

export default CardHome