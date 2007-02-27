\ ==============================================================================
\
\            ffl_test - the test-all source file in the ffl
\
\               Copyright (C) 2005  Dick van Oudheusden
\  
\ This library is free software; you can redistribute it and/or
\ modify it under the terms of the GNU General Public
\ License as published by the Free Software Foundation; either
\ version 2 of the License, or (at your option) any later version.
\
\ This library is distributed in the hope that it will be useful,
\ but WITHOUT ANY WARRANTY; without even the implied warranty of
\ MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
\ General Public License for more details.
\
\ You should have received a copy of the GNU General Public
\ License along with this library; if not, write to the Free
\ Software Foundation, Inc., 675 Mass Ave, Cambridge, MA 02139, USA.
\
\ ==============================================================================
\ 
\  $Date: 2007-02-27 19:54:10 $ $Revision: 1.23 $
\
\ ==============================================================================


include ffl/tst.fs

tst-reset-tests

\ the test sources
include act_test.fs
include bar_test.fs
include bct_test.fs
include car_test.fs
include chr_test.fs
include chs_test.fs
include cpx_test.fs
include crc_test.fs
include dcl_test.fs
include dnl_test.fs
include dtm_test.fs
include frc_test.fs
include hct_test.fs
include md5_test.fs
include rng_test.fs
include scl_test.fs
include snl_test.fs
include sh1_test.fs
include str_test.fs
include tis_test.fs
include tmr_test.fs
include tos_test.fs

.( Forth Foundation Library Test: ) tst-get-result .  .( errors in ) . .( tests took ) . .( ms.) cr
  
bye

\ ==============================================================================

