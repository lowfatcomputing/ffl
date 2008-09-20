\ ==============================================================================
\
\        spf_test - the test words for the spf module in the ffl
\
\               Copyright (C) 2008  Dick van Oudheusden
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
\  $Date: 2008-09-20 05:31:18 $ $Revision: 1.1 $
\
\ ==============================================================================

include ffl/spf.fs
include ffl/tst.fs


.( Testing: spf) cr

str-new value spf1

t{ s" hello" spf1 spf-set }t
t{ spf1 str-get s" hello" ?str }t

t{ s" value:10%%" spf1 spf-set }t
t{ spf1 str-get s" value:10%" ?str }t


t{ char ! char ? s" hello %c%c" spf1 spf-set }t
t{ spf1 str-get s" hello ?!" ?str }t

t{ char = s" %4c" spf1 spf-set }t
t{ spf1 str-get s"    =" ?str }t

t{ char = s" %-4c" spf1 spf-set }t
t{ spf1 str-get s" =   " ?str }t


t{ s" abc" s" String:%s" spf1 spf-set }t
t{ spf1 str-get s" String:abc" ?str }t

t{ s" def" s" abc" s" String:%5s %-5s" spf1 spf-set }t
t{ spf1 str-get s" String:  abc def  " ?str }t


t{ 77 88 99 s" 1:%d % d %+d" spf1 spf-set }t
t{ spf1 str-get s" 1:99  88 +77" ?str }t

t{ -77 -88 -99 s" 2:%d % d %+d" spf1 spf-set }t
t{ spf1 str-get s" 2:-99 -88 -77" ?str }t

t{ 66 77 88 99 s" 3:%4d %-4d %04d %-04d" spf1 spf-set }t
t{ spf1 str-get s" 3:  99 88   0077 66  " ?str }t

t{ 66 77 88 99 s" 4:%+4d %+-4d %0+4d %-+04d" spf1 spf-set }t
t{ spf1 str-get s" 4: +99 +88  +077 +66 " ?str }t

t{ -66 -77 -88 -99 s" 5:%4d %-4d %04d %-04d" spf1 spf-set }t
t{ spf1 str-get s" 5: -99 -88  -077 -66 " ?str }t

t{ -66 77 -88 99 s" 7:%+4i %+-4i %0+4i %-+04i" spf1 spf-set }t
t{ spf1 str-get s" 7: +99 -88  +077 -66 " ?str }t


t{ 77. 88. 99. s" 8:%ld % ld %+ld" spf1 spf-set }t
t{ spf1 str-get s" 8:99  88 +77" ?str }t

t{ -77. -88. -99. s" 9:%ld % ld %+ld" spf1 spf-set }t
t{ spf1 str-get s" 9:-99 -88 -77" ?str }t

t{ 66. 77. 88. 99. s" 10:%4ld %-4ld %04ld %-04ld" spf1 spf-set }t
t{ spf1 str-get s" 10:  99 88   0077 66  " ?str }t

t{ 66. 77. 88. 99. s" 11:%+4ld %+-4ld %0+4ld %-+04ld" spf1 spf-set }t
t{ spf1 str-get s" 11: +99 +88  +077 +66 " ?str }t

t{ -66. -77. -88. -99. s" 12:%4ld %-4ld %04ld %-04ld" spf1 spf-set }t
t{ spf1 str-get s" 12: -99 -88  -077 -66 " ?str }t


t{ 77 88 99 s" 13:%u % u %+u" spf1 spf-set }t
t{ spf1 str-get s" 13:99 88 77" ?str }t

t{ 66 77 88 99 s" 14:%4u %-4u %04u %-04u" spf1 spf-set }t
t{ spf1 str-get s" 14:  99 88   0077 66  " ?str }t

t{ 66 77 88 99 s" 15:%+4u %+-4u %0+4u %-+04u" spf1 spf-set }t
t{ spf1 str-get s" 15:  99 88   0077 66  " ?str }t


t{ 77 88 111 s" 16:%x % x %+x" spf1 spf-set }t
t{ spf1 str-get s" 16:6f 58 4d" ?str }t

t{ 66 77 88 111 s" 17:%4x %-4x %04x %-04x" spf1 spf-set }t
t{ spf1 str-get s" 17:  6f 58   004d 42  " ?str }t

t{ 66 77 88 111 s" 18:%+4x %+-4x %0+4x %-+04x" spf1 spf-set }t
t{ spf1 str-get s" 18:  6f 58   004d 42  " ?str }t


t{ 77 88 111 s" 19:%X % X %+X" spf1 spf-set }t
t{ spf1 str-get s" 19:6F 58 4D" ?str }t

t{ 66 77 88 111 s" 20:%4X %-4X %04X %-04X" spf1 spf-set }t
t{ spf1 str-get s" 20:  6F 58   004D 42  " ?str }t

t{ 66 77 88 111 s" 21:%+4X %+-4X %0+4X %-+04X" spf1 spf-set }t
t{ spf1 str-get s" 21:  6F 58   004D 42  " ?str }t


t{ 77 88 99 s" 22:%o % o %+o" spf1 spf-set }t
t{ spf1 str-get s" 22:143  130 +115" ?str }t

t{ -77 -88 -99 s" 23:%o % o %+o" spf1 spf-set }t
t{ spf1 str-get s" 23:-143 -130 -115" ?str }t

t{ 66 77 88 99 s" 24:%4o %-4o %04o %-04o" spf1 spf-set }t
t{ spf1 str-get s" 24: 143 130  0115 102 " ?str }t

t{ 66 63 88 99 s" 25:%+4o %+-4o %0+4o %-+04o" spf1 spf-set }t
t{ spf1 str-get s" 25:+143 +130 +077 +102" ?str }t

t{ -66 -63 -88 -99 s" 26:%4o %-4o %04o %-04o" spf1 spf-set }t
t{ spf1 str-get s" 26:-143 -130 -077 -102" ?str }t

variable spf-result

t{ s" All:" spf1 str-set }t
t{ spf-result 9 8 7 s" #" char * s" %c %s %d %i %u %n %%" spf1 spf-append }t
t{ spf1 str-get s" * # 7 8 9  %" ?str }t
t{ spf-result @ 14 ?s }t

t{ char ! s" hello" spf1 spf" %s !%c" }t
t{ spf1 str-get s" hello !!" ?str }t

: spf-test
  [char] ? s" bye" spf1 spf" %s %c!"
;

t{ spf-test }t
t{ spf1 str-get s" bye ?!" ?str }t


\ ==============================================================================
