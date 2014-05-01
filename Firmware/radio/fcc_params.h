// -*- Mode: C; c-basic-offset: 8; -*-
//
// Copyright (c) 2014 Luke Hovington, All Rights Reserved
//
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions
// are met:
//
//  o Redistributions of source code must retain the above copyright
//    notice, this list of conditions and the following disclaimer.
//  o Redistributions in binary form must reproduce the above copyright
//    notice, this list of conditions and the following disclaimer in
//    the documentation and/or other materials provided with the distribution.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT,
// INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
// (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
// SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
// HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT,
// STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
// ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED
// OF THE POSSIBILITY OF SUCH DAMAGE.
//

///
/// @file	fcc_params.h
///
/// Variables for FCC approval
///

#ifndef _FCC_PARAMS_H_
#define _FCC_PARAMS_H_

#include <stdint.h>
#include <stdbool.h>

#ifdef BOARD_rfd900u

typedef struct BoardRegionParams {
	uint32_t   airSpeed;
	uint32_t   minFreq;
	uint32_t   maxFreq;
	uint32_t   numChannels;
} BoardRegionParams_t;

#define FCC_LOCK_PARAMS {\
{64, 915000UL, 928000UL, 20}, /* REGION_AU */\
{64, 915000UL, 928000UL, 20}, /* REGION_NZ */\
{64, 915000UL, 928000UL, 20}, /* REGION_US */\
}

#endif //BOARD_rfd900u
#endif