# coding: utf-8
# pygost -- Pure Python GOST cryptographic functions library
# Copyright (C) 2015-2016 Sergey Matveev <stargrave@stargrave.org>
#
# This program is free software: you can redistribute it and/or modify
# it under the terms of the GNU General Public License as published by
# the Free Software Foundation, either version 3 of the License, or
# (at your option) any later version.
#
# This program is distributed in the hope that it will be useful,
# but WITHOUT ANY WARRANTY; without even the implied warranty of
# MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
# GNU General Public License for more details.
#
# You should have received a copy of the GNU General Public License
# along with this program.  If not, see <http://www.gnu.org/licenses/>.
""" GOST R 34.10 public-key signature function.
This is implementation of GOST R 34.10-2001 (:rfc:`5832`), GOST R
34.10-2012 (:rfc:`7091`). The difference between 2001 and 2012 is the
hash function and corresponding digest and signature lengths.
"""

from os import urandom

from utils import bytes2long
from utils import hexdec


MODE2SIZE = {
    2001: 32,
    2012: 64,
}


DEFAULT_CURVE = "GostR3410_2012_TC26_ParamSetA"
# Curve parameters are the following: p, q, a, b, x, y
CURVE_PARAMS_TEXT = {
    # Curve params truncated, only params defined in GOSTR3410_2012 whitepaper here.
    # For more curve params visit http://git.cypherpunks.ru/cgit.cgi/pygost.git/tree/pygost/gost3410.py#n121
    "GostR3410_2012_TC26_ParamSetA": (
        "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFDC7",
        "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF27E69532F48D89116FF22B8D4E0560609B4B38ABFAD2B85DCACDB1411F10B275",
        "FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFDC4",
        "E8C2505DEDFC86DDC1BD0B2B6667F1DA34B82574761CB0E879BD081CFD0B6265EE3CB090F30D27614CB4574010DA90DD862EF9D4EBEE4761503190785A71C760",
        "00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000003",
        "7503CFE87A836AE3A61B8816E25450E6CE5E1C93ACF1ABC1778064FDCBEFA921DF1626BE4FD036E93D75E6A50E3A41E98028FE5FC235F5B889A589CB5215F2A4",
    ),
    "GostR3410_2012_TC26_ParamSetB": (
        "8000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000006F",
        "800000000000000000000000000000000000000000000000000000000000000149A1EC142565A545ACFDB77BD9D40CFA8B996712101BEA0EC6346C54374F25BD",
        "8000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000006C",
        "687D1B459DC841457E3E06CF6F5E2517B97C7D614AF138BCBF85DC806C4B289F3E965D2DB1416D217F8B276FAD1AB69C50F78BEE1FA3106EFB8CCBC7C5140116",
        "00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000002",
        "1A8F7EDA389B094C2C071E3647A8940F3C123B697578C213BE6DD9E6C8EC7335DCB228FD1EDF4A39152CBCAAF8C0398828041055F94CEEEC7E21340780FE41BD"
    ),
}

CURVE_PARAMS = {}
for c, params in CURVE_PARAMS_TEXT.items():
    CURVE_PARAMS[c] = [hexdec(param) for param in params]


def sign(curve, prv, digest, mode=2012):
    """
    :param GOST3410Curve curve: curve
    :param long prv: private key
    :param digest: digest for signing
    :type digest: bytes, 32 or 64 bytes
    :returns: signature
    :rtype: int tuple
    """
    # size = MODE2SIZE[mode]
    size = 64
    q = curve.q
    e = bytes2long(digest) % q
    if e == 0:
        e = 1
    while True:
        k = bytes2long(urandom(size)) % q
        if k == 0:
            continue
        r, _ = curve.exp(k)
        r %= q
        if r == 0:
            continue
        d = prv * r
        k *= e
        s = (d + k) % q
        if s == 0:
            continue
        break
    # return long2bytes(s, size) + long2bytes(r, size)
    return r, s