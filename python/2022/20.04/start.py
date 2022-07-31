from gost import gost341012
from structs import SignatureSequence

def create_signature(curve, prv, dgst, filename='', filesize=0):
    signature = gost341012.sign(curve, prv, dgst, 2012)
    pub = gost341012.public_key(curve, prv)
    s = SignatureSequence()

    params = s.getComponentByName('params').getComponentByName('keydatasquence')
    params.setComponentByName('text', 'gostSignKey')
    params.setComponentByName('algo', b'80060700')
    openkey = params.getComponentByName('open_key')
    openkey.setComponentByName('x', pub[0])
    openkey.setComponentByName('y', pub[1])

    cryptoparams = params.getComponentByName('cryptosystem_p')
    cryptoparams.setComponentByName('p', curve.p)

    curveparams = params.getComponentByName('curve_p')
    curveparams.setComponentByName('a', curve.a)
    curveparams.setComponentByName('b', curve.b)

    dotsparams = params.getComponentByName('dots_p')
    dotsparams.setComponentByName('x', curve.x)
    dotsparams.setComponentByName('y', curve.y)

    params.setComponentByName('q', curve.q)

    sign = s.getComponentByName('sign')
    sign.setComponentByName('r', signature[0])
    sign.setComponentByName('s', signature[1])

    metadata = s.getComponentByName('meta')
    metadata.setComponentByName('filename', filename)
    metadata.setComponentByName('filesize', filesize)
    return s

def sign_file(path, curve, prv, dgst_f=default_dgstr):
    try:
        with open(path, 'rb') as file:
            data = file.read()
            dgst = dgst_f(data)
            print('Message hash:', str(hexlify(dgst)))

            s = create_signature(curve, prv, dgst, filename=basename(path), filesize=len(data))
            print('\nGenerated ASN.1 file:\n')
            print(s.prettyPrint())
            with open(path + '.sign', 'wb') as sign_f:
                sign_f.write(encoder.encode(s))
    except Exception as e:
        print(e)
    else:
        return True

if __name__ == '__main__':
    from os import urandom
    curve_params = gost341012.CURVE_PARAMS["GostR3410_2012_TC26_ParamSetA"]
    curve = gost341012.GOST3410Curve(*curve_params)
    prv_raw = urandom(32)
    prv = gost341012.prv_unmarshal(prv_raw)
    sign_file('./testdata/lorem.txt', curve, prv)