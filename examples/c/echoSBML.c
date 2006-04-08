/**
 * \file    echoSBML.c
 * \brief   Echos (and pretty prints) an SBML model.
 * \author  Ben Bornstein
 *
 * $Id$
 * $Source$
 */
/* Copyright 2006 California Institute of Technology and Japan Science and
 * Technology Corporation.
 *
 * This library is free software; you can redistribute it and/or modify it
 * under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation.  A copy of the license agreement is
 * provided in the file named "LICENSE.txt" included with this software
 * distribution.  It is also available online at
 * http://sbml.org/software/libsbml/license.html
 *
 * You should have received a copy of the GNU Lesser General Public License
 * along with this library; if not, write to the Free Software Foundation,
 * Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA.
 */


#include <stdio.h>
#include <sbml/SBMLTypes.h>


int
main (int argc, char *argv[])
{
  if (argc != 3)
  {
    printf("\n  usage: echoSBML <input-filename> <output-filename>\n\n");
    return 2;
  }

  writeSBML(readSBML(argv[1]), argv[2]);
  return 0;
}
